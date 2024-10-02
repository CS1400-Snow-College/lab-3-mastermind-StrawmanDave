// See https://aka.ms/new-console-template for more information
Console.Clear();

/*
list of letters: a, b, c, d, e, f, g.
*/

Console.WriteLine("Try to guess the 4 letter password it has letters between a and g with no capitals.");
string secret = "bade";
string guess = "";
int numOfGuess = 0;
int rightPosition = 0;
int wrongPosition = 0;

while(guess != secret){

  numOfGuess ++;
  Console.WriteLine($"Guess #{numOfGuess} please guess a sequence of 4 lower case letters with no repeats");
  guess = Console.ReadLine();

  for(int i = 0; i<secret.Length; i ++)
  {

      for (int j = 0; j <guess.Length; j++)
    {
      if(secret[i] == guess[j] && i == j)
      {
      rightPosition ++;
      }
      else if(guess[j] == secret[i])
        {
          wrongPosition ++;
        }
  
    }
}
  Console.WriteLine($"{rightPosition} in the right position");
  Console.WriteLine($"{wrongPosition} in the wrong position");
  rightPosition = 0;
  wrongPosition = 0;

}
Console.WriteLine($"You guessed the password in {numOfGuess} guesses");

