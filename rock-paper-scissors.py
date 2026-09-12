import random

print("Hello, Player! Welcome to the Astrology Rock-Paper-Scissors game.")
valid_zodiac_signs = ["Aries","aries", "Taurus","taurus", "Gemini","gemini", "Cancer","cancer", "Leo","leo", "Virgo","virgo",
                      "Libra","libra", "Scorpio","scorpio", "Sagittarius","sagittarius", "Capricorn","capricorn", "Aquarius","aquarius", "Pisces","pisces"]
print("First, please enter your zodiac sign (e.g., Aries, Taurus, Gemini, etc.):")
zodiac_sign = input().strip().capitalize() 

if zodiac_sign not in valid_zodiac_signs:
    print("Invalid zodiac sign! Please enter a valid zodiac sign.")
else:
    print(f"Great! Your zodiac sign is {zodiac_sign}. Let's play Astrology Rock-Paper-Scissors!")
    
    choices = ["rock", "paper", "scissors"]
    
    while True:
        computer_choice = random.choice(choices)
        
        player_choice = input("Please choose rock, paper, or scissors (or 'quit' to exit): ").strip().lower()
        
        if player_choice == "quit":
            print(f"Thank you for playing! {zodiac_sign} Goodbye!")
            break
        
        if player_choice not in choices:
            print("Invalid choice! Please choose rock, paper, or scissors.")
            continue
        
        print(f"Computer chose: {computer_choice}")
        
        if player_choice == computer_choice:
            print(f"It's a tie! Both you and the computer chose {player_choice}.")
        else:
            if (player_choice == "rock" and computer_choice == "scissors") or \
               (player_choice == "paper" and computer_choice == "rock") or \
               (player_choice == "scissors" and computer_choice == "paper"):
                print(f"You win! {player_choice.capitalize()} beats {computer_choice}.")
            else:
                print(f"You lose! {computer_choice.capitalize()} beats {player_choice}.")
        
        print() 


