# Assignment1
* MAPD's Backend Development first assignment

## Requirements
* This api works with query strings a and b.
  a will always be the first number in order while b is the second

_Enjoy :smiley:_

### Issues in Unit Test
* I moved the Calculator logic to a string library and added the references. But on calling
 the libray in the Calculator controller I am getting:

 The type or namespace name 'Add' does not exist in the namespace 'Calculator' (are you missing an assembly reference?)CS0234
# Fix
* I was giving the libary class same name as the namespace. I had to change my calculator
 namespace to CalculatorUtility