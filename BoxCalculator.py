import math
#Setting up variables for the different sizes of boxes
Big = 5
Medium = 3
Small = 1
#Big can store 5 items, medium can store 3 items and small can store 1 item

items = int(input('How many items do you have? ')) #This is the input variable for the user to input their value. Casted to integer so program only runs if an integer is inputted.

#Below is the code to calculate the amount of boxes needed to store the items
Big_Box = math.floor(items / Big)
Big_Box_Remainder = items % Big

Medium_Box = math.floor(Big_Box_Remainder / Medium)

Small_Box = Big_Box_Remainder % Medium

print(f'You will need {int(Big_Box+Medium_Box+Small_Box)} Boxes in total.\n\nYou need {int(Big_Box)} Big Boxes, {int(Medium_Box)} Medium Boxes, {int(Small_Box)} Small Boxes to store your items.')
#The above print statement shows the total boxes needed and big, medium and small boxes needed to hold the items inputted. There are no loops so the program only runs once.

#Test assertion1: input of 5 items should return 1 box with only 1 big box.
#Test assertion2: input of 51 items should return 11 boxes with 10 big boxes and 1 small box.
#Test assertion3: input of 17 items should return 5 boxes with 3 big boxes and 2 small boxes.

#Medium_Box and Big_Box results in decimals which causes rounding issues when added together.
