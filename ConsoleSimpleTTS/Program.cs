using System;
using SpeechLib;

namespace ConsoleSimpleTTS
{
	class Program
	{
		/// <summary>
		/// Simple TTS 
		/// </summary>
		/// <param name="args">args[0]: Message, args[1]: Attributes e.g. "Language=409;Gender=Female"</param>
		static void Main(string[] args)
		{
			SpVoice voice = new SpVoice();

			voice.Volume = 100; // Volume
			voice.Rate = 0 ;    // Rate

			SpObjectTokenCategory tokenCat = new SpObjectTokenCategory();
			tokenCat.SetId(SpeechLib.SpeechStringConstants.SpeechCategoryVoices, false);

			string requiredAttributes = null;

			if(args.Length > 1)
			{
				// Select tokens
				//     (Language:409=English (United States)/411=Japanese, Gender:Male/Female ... )
				requiredAttributes = args[1];
			}

			ISpeechObjectTokens tokens = tokenCat.EnumerateTokens(requiredAttributes, null);

			// No tokens
			if(tokens.Count==0)
			{
				// Reselect
				tokens = tokenCat.EnumerateTokens(null, null); // Get all tokens
			}

			voice.Voice = tokens.Item(0);

			string message = "Hello World!";

			if(args.Length > 0)
			{
				message = args[0];
			}
			voice.Speak(message, SpeechVoiceSpeakFlags.SVSFDefault);

			Console.WriteLine("Finished");
		}
	}
}
