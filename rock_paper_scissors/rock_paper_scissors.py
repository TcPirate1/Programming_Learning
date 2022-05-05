from tkinter import *
from random import randint
from tkinter import ttk

root=Tk()
root.title('Rock Paper Scissors')
root.geometry('600x700')
root.config(bg='white')

#Defining images
rock=PhotoImage(file="rock.gif")
paper=PhotoImage(file="paper.gif")
scissors=PhotoImage(file="scissors.gif")

#Adding images to a list
image_list=[rock,paper,scissors]

#Get a random number
rand_num=randint(0,2)

#putting image on screen
image_label=Label(root,image=image_list[rand_num])
image_label.pack()

#create spin function
def spin():
    #Pick random number
    rand_num=randint(0,2)
    #Show image
    image_label.config(image=image_list[rand_num])
    # Turn player choice into number
    if player_choice.get()=='Rock':
        player_choice_value=0
    elif player_choice.get()=='Paper':
        player_choice_value=1
    elif player_choice.get()=='Scissors':
        player_choice_value=2
    #player picks Rock
    if player_choice_value==0:
        if rand_num==0:
            result_label.config(text='Draw!')
        elif rand_num==1:
            result_label.config(text='You lose!')
        elif rand_num==2:
            result_label.config(text='You Win!')
    #player picks Paper
    if player_choice_value==1:
        if rand_num==0:
            result_label.config(text='You win!')
        elif rand_num==1:
            result_label.config(text='Draw!')
        elif rand_num==2:
            result_label.config(text='You lose!')
    #player picks Scissors
    if player_choice_value==2:
        if rand_num==0:
            result_label.config(text='You lose!')
        elif rand_num==1:
            result_label.config(text='You win!')
        elif rand_num==2:
            result_label.config(text='Draw!')


# Player choice
player_choice=ttk.Combobox(root,value=('Rock','Paper','Scissors'))
player_choice.current(0)
player_choice.pack(pady=10)

# Spin button
spin_button = Button(root,text='Spin', command=spin)
spin_button.pack(pady=10)

#Label for results
result_label=Label(root,text='',font='arial 14')
result_label.pack(pady=40)

root.mainloop()