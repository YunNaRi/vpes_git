// Performs addition, subtraction, multiplication or division depending the input from user

#include <stdio.h>

double firstNumber;
double firstNumber1;

double firstNumber2;

void add(double firstNumber, double secondNumber) {
 printf("%.1lf + %.1lf = %.1lf",firstNumber, secondNumber, firstNumber + secondNumber);
 if(firstNumber1<0){
  firstNumber2+0;
  multiply(firstNumber, secondNumber);
 }
 else{
  firstNumber+secondNumber;
  divide(firstNumber, secondNumber);
 }
 //subtract(firstNumber, secondNumber);
}

void subtract(double firstNumber, double secondNumber) {
 printf("%.1lf - %.1lf = %.1lf",firstNumber, secondNumber, firstNumber - secondNumber);
}

void multiply(double firstNumber, double secondNumber) {
 printf("%.1lf * %.1lf = %.1lf",firstNumber, secondNumber, firstNumber * secondNumber);
 if(firstNumber==1){

   firstNumber+0;
   subtract(firstNumber, secondNumber);
  }  else if(firstNumber==2){

   firstNumber+0;
   subtract(firstNumber, secondNumber);
  }  else{
   firstNumber+secondNumber;
   divide(firstNumber, secondNumber);
  }
}

void divide(double firstNumber, double secondNumber) {
 printf("%.1lf / %.1lf = %.1lf",firstNumber, secondNumber, firstNumber / secondNumber);
 if(firstNumber>0){
   firstNumber+0;
//   multiply(firstNumber, secondNumber);
  }
  else{
   firstNumber+secondNumber;
   subtract(firstNumber, secondNumber);
  }
}

void longNameFunctionTestlongNameFunctionTestlongNameFunctionTestDividea(double longNameFunctionTestlongNameFunctionTestlongNameFunctionTestParam, double secondNumber) {
 printf("%.1lf / %.1lf = %.1lf",firstNumber, secondNumber, firstNumber / secondNumber);
}

void longNameFunctionTestlongNameFunctionTestlongNameFunctionTestDivideb(double longNameFunctionTestlongNameFunctionTestlongNameFunctionTestParam, double secondNumber) {
 printf("%.1lf / %.1lf = %.1lf",firstNumber, secondNumber, firstNumber / secondNumber);
}

void longNameFunctionTestlongNameFunctionTestlongNameFunctionTestDividec(double longNameFunctionTestlongNameFunctionTestlongNameFunctionTestParam, double secondNumber) {
 printf("%.1lf / %.1lf = %.1lf",firstNumber, secondNumber, firstNumber / secondNumber);
}

int main() {

    char operator;
    double firstNumber,secondNumber;

    printf("Enter an operator (+, -, *,): ");
    scanf("%c", &operator);

    printf("Enter two operands: ");
    scanf("%lf %lf",&firstNumber, &secondNumber);

    switch(operator)
    {
        case '+':
            add(firstNumber, secondNumber);
            break;

        case '-':
            subtract(firstNumber, secondNumber);
            break;

        case '*':
            multiply(firstNumber, secondNumber);
            break;

        case '/':
            divide(firstNumber, secondNumber);
            break;

        // operator doesn't match any case constant (+, -, *, /)
        default:
            printf("Error! operator is not correct");
    }
    
    return 0;
}
