#include <iostream>
using namespace std;
main(){
    int num1,num2;
    cout <<"Digite um numero: ";
    cin >> num1;
    cout <<"Digite outro numero: ";
    cin >> num2;
    if(num1%num2==0||num2%num1==0)
    {
        cout <<"Eles sao multiplos!";
    }
    else
    {
        cout <<"Eles nao sao multiplos!";
    }
}