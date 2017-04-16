using System;
using System.Collections.Generic;

namespace RatingTraining.Models
{
	public class Player
	{
		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the game.
		/// </summary>
		/// <value>The game.</value>
		public string Game { get; set; }

		/// <summary>
		/// Gets or sets the rating.
		/// </summary>
		/// <value>The rating.</value>
		public int Rating { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="T:RatingTraining.Models.Player"/> class.
		/// </summary>
		/// <param name="name">Name.</param>
		/// <param name="game">Game.</param>
		/// <param name="rating">Rating.</param>
		public Player(string name, string game, int rating)
		{
			this.Name = name;
			this.Game = game;
			this.Rating = rating;
		}
	}

	public static class PlayerData
	{
		public static List<Player> GetPlayers()
		{
			List<Player> data = new List<Player>();
			data.Add(new Player("Bill Evans", "Tic Tac Toe", 4));
			data.Add(new Player("Oscar Peterson", "Spin the Bottle", 5));
			data.Add(new Player("Dave Brubeck", "Texas Hold 'em Poker", 2));
			return data;
		}
	}
}
