using CorpCommentReact.Server.Models;
using CorpCommentReact.Server.Responses;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCors(options =>
{
	options.AddPolicy("AllowAllOrigins",
		builder =>
		{
			builder.AllowAnyOrigin()
				   .AllowAnyMethod()
				   .AllowAnyHeader();
		});
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options =>
	options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

builder.Services.AddLogging();
app.UseCors("AllowAllOrigins");
//app.UseDefaultFiles();
//app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.UseAuthorization();

app.MapControllers();

// await dbContext.Feedbacks.ToListAsync());
//GET https://localhost:7290/feedbacks
app.MapGet("/feedbacks", async (AppDbContext dbContext) =>
{
	return new FeedbackResponse
	{
		Feedbacks = await dbContext.Feedbacks.ToListAsync()
	};
});
//POST https://localhost:7290/feedbacks
app.MapPost("/feedbacks", async (AppDbContext dbContext, Feedback feedback, ILogger<Program> logger) =>
{
	if (feedback == null)
	{
		logger.LogWarning("Received null feedback");
		return Results.BadRequest();
	}

	logger.LogInformation($"Received feedback: {JsonSerializer.Serialize(feedback)}");

	dbContext.Feedbacks.Add(feedback);
	await dbContext.SaveChangesAsync();
	logger.LogInformation($"Feedback saved with ID: {feedback.Id}");
	return Results.NoContent();
});
//PUT https://localhost:7290/feedbacks
app.MapPut("/feedbacks/{id}", async (AppDbContext dbContext, int id, Feedback inputFeedback) =>
{
	var feedback = await dbContext.Feedbacks.FindAsync(id);

	if (feedback is null) return Results.NotFound();

	feedback.UpvoteCount = inputFeedback.UpvoteCount;

	await dbContext.SaveChangesAsync();

	return Results.NoContent();
});

app.Run();
