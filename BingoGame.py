#BingoGame

print('Hello player! Welcome to Bingo!') #Greeting message

bingo_card=[1,6,19,57,78,69,80,12,35,45,55,77,8] #Our bingo card

while bingo_card!=[]: #This while statement will keep the loop going as long as the bingo card is not empty
    player_input= int(input('\nPlayer! Input a number between 1 and 80: ')) #Input and prompt for player to input a number between 1 and 80.
    if player_input in bingo_card: #This if statement checks to see if the input is inside the list, bingo_card.
        bingo_card.remove(player_input) #If it is inside the list then the input will be removed from the bingo_card.
        print('\nThat was correct, the number will be crossed off your card!\n') #Tells the player if they inputted a number in the bingo_card.
        print(bingo_card) #Prints out the updated bingo_card list.
    elif player_input not in bingo_card: #This statement runs if the above statement is false, it runs if the input is not a number in the bingo_card.
        print('\nThat was not on your card, try again.\n') #Tells the player that their inputted number was not on the bingo_card.
    if bingo_card==[]: # When the bingo_card list is empty then this if statement runs.
        print('Bingo!\n\nThe game has finished, hope you enjoyed playing!') #Lets the player knows that they've won.
        break #Breaks the loop, stops the game.

#Test assertions of while statement: The program loops without needing the code to be run again.
#Test assertions of first if statement: When a number is entered the first if statement runs correctly, numbers are removed from the list. The order of entry does not matter.
#Test assertions of elif statement: When a number not in the list is entered no numbers are removed. This runs correctly.
#Test assertions of 2nd if statement and break statement: Correctly runs when all numbers are removed. The loops stops and the message is displayed.