// DataSeeder.cs
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CorpCommentReact.Server.Models;

public class DataSeeder : IEntityTypeConfiguration<Feedback>
{
	public void Configure(EntityTypeBuilder<Feedback> builder)
	{
		builder.HasData(
			new Feedback
			{
				Id = 1,
				UpvoteCount = 593,
				BadgeLetter = "B",
				Company = "ByteGrad",
				Text = "Hi #ByteGrad, I really like the courses. 😁 I just wish that you would produce more of them and faster. That would be great, as I want to be a dev!",
				DaysAgo = 4
			},
			new Feedback
			{
				Id = 2,
				UpvoteCount = 563,
				BadgeLetter = "S",
				Company = "Starbucks",
				Text = "I really wish #Starbucks would use hand wrappers for hot drinks as a standard, I keep burning my hands and am tired of bothering the employee.",
				DaysAgo = 3
			},
			new Feedback
			{
				Id = 3,
				UpvoteCount = 486,
				BadgeLetter = "N",
				Company = "Netflix",
				Text = "Since yesterday on mobile #netflix keeps buffering the video, it keeps happening even when I redownload the app. I'm in an area with decent internet btw.",
				DaysAgo = 5
			},
			new Feedback
			{
				Id = 4,
				UpvoteCount = 377,
				BadgeLetter = "M",
				Company = "McDonald's",
				Text = "It's a real shame that my local #mcdonald's removed milkshakes from the menu. They were the reason I go to McDonald's. 😩 Please bring them back!",
				DaysAgo = 2
			},
			new Feedback
			{
				Id = 5,
				UpvoteCount = 156,
				BadgeLetter = "A",
				Company = "Amazon",
				Text = "I'm an #amazon prime member but don't really watch the prime video offering. Instead of that I would want an option for even faster delivery 😎",
				DaysAgo = 1
			},
			new Feedback
			{
				Id = 6,
				UpvoteCount = 88,
				BadgeLetter = "N",
				Company = "Netflix",
				Text = "Would be great if #netflix could announce content removals further ahead. 😊 I don't want to get into a show only for it to be gone soon. Thanks.",
				DaysAgo = 1
			},
			new Feedback
			{
				Id = 7,
				UpvoteCount = 41,
				BadgeLetter = "M",
				Company = "Microsoft",
				Text = "I've been using #microsoft teams for a couple of weeks now and one thing that really sticks out is that navigation is too difficult. Please simplify it.",
				DaysAgo = 1
			},
			new Feedback
			{
				Id = 8,
				UpvoteCount = 39,
				BadgeLetter = "N",
				Company = "Nike",
				Text = "Hi #nike I love your running shoes but it's very difficult to return them after a purchase. Had to do a lot of phone calls to make it work. Thanks 👍",
				DaysAgo = 5
			},
			new Feedback
			{
				Id = 9,
				UpvoteCount = 22,
				BadgeLetter = "M",
				Company = "McDonald's",
				Text = "#mcdonald's the past few times I've been some items were missing from my order. Only noticed this when I got home. Straws, nuggets, fries, they missed.",
				DaysAgo = 2
			},
			new Feedback
			{
				Id = 10,
				UpvoteCount = 9,
				BadgeLetter = "A",
				Company = "Adidas",
				Text = "I like your website #adidas, but your sizing guide needs some work. It suggested an L for me but when it arrived it was too big. Still kept it btw 😎",
				DaysAgo = 3
			}
		);
	}
}
