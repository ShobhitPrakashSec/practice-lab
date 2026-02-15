import random

def guess_by_user(low, high):
    random_number = random.randint(low, high)
    guess = None
    
    while guess != random_number:
        try:
            guess = int(input(f"Guess the number between {low} and {high} number... ")
                        )            
            if guess > high or guess < low:
                print("Out of range.")
            elif guess > random_number:
                print("Your guess is too high.")
            elif guess < random_number:
                print("Your guess is too low.")
        except ValueError:
            print("Invalid input. Enter an integer.")
            
    print(f"Your guess {random_number} is correct.")
    
def guess_by_computer(low, high):
    feedback = ''
    computer_guess = 0
    
    while feedback != 'c':
        if low <= high:
            computer_guess = random.randint(low, high)
        else:
            print("Logic error. Your values are contradictory.")
            break
        
        feedback = input(f"Is my guess {computer_guess} correct (c), too high (h), or  too low (l): ").lower()
        
        if feedback == 'h':
            high = computer_guess - 1
        elif feedback == 'l':
            low = computer_guess + 1
        elif feedback != 'c' :
            print("Invalid input. Enter 'c', 'h', or 'l'.")
    
    if feedback == 'c':
        print(f"Yay! My guess {computer_guess} is correct.")
    
print("""Welcome to the game Guess Number.
You can play two types of games. Either you guess the number or computer guess your number depending on your choice.
To play game "guess by user", enter 1.
Or, to play game "guess bu computer", enter 2.""")
choice = int(input("Enter your choice '1' or '2'... "))
lower_value = int(input("Enter the lower value: "))
higher_value = int(input("Enter the higher value: "))

if choice == 1:
    guess_by_user(lower_value, higher_value)
elif choice == 2:
    guess_by_computer(lower_value, higher_value)
else:
    print("Invalid input. You have to enter either 1 or 2 only. Please restart the game.")