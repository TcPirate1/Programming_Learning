#BingoGame
import random

print('Hello player! Welcome to Bingo!') #Greeting message

bingo_card=[random.randrange(1,80) for x in range(13)]
print(bingo_card) #Our bingo card

while bingo_card != []: #This while statement will keep the loop going as long as the bingo card is not empty
    player_input = int(input('\nPlayer! Input a number between 1 and 80: '))
    if player_input in bingo_card: #This if statement checks to see if the input is inside the list, bingo_card.
        bingo_card.remove(player_input) #If it is inside the list then the input will be removed from the bingo_card.
        print('\nThat was correct, the number will be crossed off your card!\n')
        print(bingo_card)
    elif player_input not in bingo_card: #This statement runs if the above statement is false, it runs if the input is not a number in the bingo_card.
        print('\nThat was not on your card, try again.\n')
    if bingo_card == []: # When the bingo_card list is empty then this if statement runs.
        print('Bingo!\n\nThe game has finished, hope you enjoyed playing!')
        break #Breaks the loop, stops the game.