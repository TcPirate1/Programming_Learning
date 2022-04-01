#Grade_Calculator

project_grade = float(input('Project percent: '))
exam_grade = float(input('Exam percent: '))
final_grade = ((project_grade + exam_grade)*0.5)

#The above variables have our inputs and calculations stored. Floats are casted to the input as percentages can contain decimals in them. We will also multiply the results by a decimal (0.5) so it is possible for the output to have a decimal.

if final_grade>=80 and final_grade<=100:
    print(f'Your final grade is A with a score of {final_grade}%')
elif final_grade>=70:
    print(f'Your final grade is B with a score of {final_grade}%')
elif final_grade>=60:
    print(f'Your final grade is C with a score of {final_grade}%')
elif final_grade>=50:
    print(f'Your final grade is D with a score of {final_grade}%')
elif final_grade<=49 and final_grade>=0:
    print(f'You failed with a score of {final_grade}%')
else:
    print(f'There is an error, please check the grades were entered correctly.')

#The above if/elif/else statements have the grade boundries for the program. And statements are only used for the if statement and the else statement as grades cannot go above 100% or lower than 0% but the other grade boundaries do not need and statements as the program will go to the next elif statement if the first grade condition was not met.
#And statements are used rather than or statements because we need both boundaries to be true for the correct grade to be given.

#Test assertion 1: input of project grade=78% and exam grade=65% should give 71.5% for final grade of B.
#Test assertion 2: input of project grade=54% and exam grade=56% should give for final grade of D.
#Test assertion 3: input of project grade=38% and exam grade=45% should give for final grade of fail.