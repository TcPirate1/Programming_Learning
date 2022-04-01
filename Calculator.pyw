from tkinter import *

# Create window
window = Tk()
window.title('Calculator')
window.configure(bg='cyan')
window.geometry('440x360')

#Variable for calculations
expression=''
equation=StringVar()
equation1=StringVar()

#button press function
def Click(but):
    global expression
    expression=expression+str(but)
    equation.set(expression)

#Equals function
def Equals():
    try:
        global expression
        total=str(eval(expression))
        Alt_total=round(float(total),3)
        equation.set(f'{str(Alt_total)}')
        expression=str(Alt_total)
    except:
        equation.set('Computer says no')
        expression=''
    

#clear function-normal
def Clear_normal():
    global expression
    expression=''
    equation.set('')

#clear function-convertion
def Clear_convert():
    global expression
    expression=''
    equation1.set('')

#Clear both boxes
def Clear_both():
    global expression
    expression=''
    equation.set('')
    equation1.set('')

#conversion functions
def InchConvert():
    global expression
    total=float(expression)*2.54
    equation1.set(f'{str(round(total,3))} Centimeters')
    expression=str(total)

def CmConvert():
    global expression
    total=float(expression)/2.54
    equation1.set(f'{str(round(total,3))} Inches')
    expression=str(total)


#Make numpad buttons 7,4,1 and decimal
but_num_7=Button(window, bg='White', fg='black',font='arial 14',text='7',width=4,height=1, command=lambda:Click(7)).place(x=30,y=155)
but_num_4=Button(window, bg='White', fg='black',font='arial 14',text='4',width=4,height=1,command=lambda:Click(4)).place(x=30,y=194)
but_num_1=Button(window, bg='White', fg='black',font='arial 14',text='1',width=4,height=1,command=lambda:Click(1)).place(x=30,y=233)
but_decimal=Button(window, bg='White', fg='black',font='arial 14',text='.',width=4,height=1,command=lambda:Click('.')).place(x=30,y=272)

#Make numpad buttons 8,5,2 and 0
but_num_8=Button(window, bg='White', fg='black',font='arial 14',text='8',width=4,height=1,command=lambda:Click(8)).place(x=85,y=155)
but_num_5=Button(window, bg='White', fg='black',font='arial 14',text='5',width=4,height=1,command=lambda:Click(5)).place(x=85,y=194)
but_num_2=Button(window, bg='White', fg='black',font='arial 14',text='2',width=4,height=1,command=lambda:Click(2)).place(x=85,y=233)
but_num_0=Button(window, bg='White', fg='black',font='arial 14',text='0',width=4,height=1,command=lambda:Click(0)).place(x=85,y=272)

#Make numpad buttons 9,6,3 and equal
but_num_9=Button(window, bg='White', fg='black',font='arial 14',text='9',width=4,height=1,command=lambda:Click(9)).place(x=140,y=155)
but_num_6=Button(window, bg='White', fg='black',font='arial 14',text='6',width=4,height=1,command=lambda:Click(6)).place(x=140,y=194)
but_num_3=Button(window, bg='White', fg='black',font='arial 14',text='3',width=4,height=1,command=lambda:Click(3)).place(x=140,y=233)
but_num_equals=Button(window, bg='White', fg='black',font='arial 14',text='=',width=4,height=1,command=Equals).place(x=140,y=272)

#Make operator buttons
but_num_plus=Button(window, bg='White', fg='black',font='arial 14',text='+',width=4,height=1,command=lambda:Click('+')).place(x=265,y=200)
but_num_minus=Button(window, bg='White', fg='black',font='arial 14',text='-',width=4,height=1,command=lambda:Click('-')).place(x=320,y=200)
but_num_multiply=Button(window, bg='White', fg='black',font='arial 14',text='x',width=4,height=1,command=lambda:Click('*')).place(x=265,y=240)
but_num_divide=Button(window, bg='White', fg='black',font='arial 14',text='÷',width=4,height=1,command=lambda:Click('/')).place(x=320,y=240)

#Make conversion buttons
but_InchesToCM=Button(window, bg='White', fg='black',font='arial 14',text='Inches to Centimeters',command=InchConvert).place(x=230,y=110,height=35)
but_CmToInches=Button(window, bg='White', fg='black',font='arial 14',text='Centimeters to Inches',command=CmConvert).place(x=230,y=150,height=35)

#Clear buttons for norm and convert and for both
but_num_ClearNormal=Button(window, bg='White', fg='black',font='arial 14',text='Clear this box',width=16,height=1,command=Clear_normal).place(x=15,y=5)
but_num_ClearConvert=Button(window, bg='White', fg='black',font='arial 14',text='Clear this box',width=16,height=1,command=Clear_convert).place(x=240,y=5)
but_ClearBoth=Button(window, bg='White', fg='black',font='arial 14',text='Clear both boxes',width=14,height=1,command=Clear_both).place(x=30,y=110)

#Make calculation entry boxes
calculationBox=Entry(window,textvariable=equation, bg='white', fg='black',font='arial 14').place(x=10,y=50,width=200,height=50)
convertionBox=Entry(window,textvariable=equation1, bg='white', fg='black',font='arial 14').place(x=230,y=50,width=200,height=50)

window.mainloop()