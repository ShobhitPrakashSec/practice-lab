import random
from textwrap import dedent

def play_user_vs_computer(player, computer):    
    if player == computer:
        return "It's a tie."
        
    if is_win(player, computer):
        return "You win."
    
    return "You lose."

def play_user_vs_user(player1, player2):
    if player1 == player2:
        return "It's a tie."
    
    if is_win(player1, player2):
        return "Player 1 win."
    
    return "Player 2 win."

def is_win(opponent1, opponent2):
    if (opponent1 == 'r' and opponent2 == 's') or (opponent1 == 's' and  opponent2 == 'p') or (opponent1 == 'p' and opponent2 == 'r'):
        return True

def main():
    print("".center(80, "="))
    text = dedent("""Welcome to the Rock, Paper and Scissor game.
You can either play with your friend and computer depending on your choice.
User vs User: 1 OR User vs Computer: 2
""")
    for line in text.splitlines():
        print(line.center(80))
    print("".center(80, "="))
    
    choice = input("'1' OR '2': ")
    if choice == '1':
        player_choice1 = input("Player 1 please type our choice ('r' for rock or 's' for scissor or 'p' for paper): ")
        player_choice2 = input("Player 2 please type our choice ('r' for rock or 's' for scissor or 'p' for paper): ")
        print(play_user_vs_user(player_choice1, player_choice2))
    else:
        player = input("Type our choice ('r' for rock or 's' for scissor or 'p' for paper): ")
        computer = random.choice(['r', 'p', 's'])
        print(play_user_vs_computer(player, computer))
    
    print("".center(80, "="))
   

main()