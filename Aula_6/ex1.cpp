#include<iostream>
#include <string>
using namespace std;

void inverter(string num){
    num = string(1, num[9]) + num[8] + num[7] + num[6] + num[5] + num[4] + num[3] + num[2] + num[1] + num[0];
    cout << num;
}

int main(){
    string num;
    cout << "Digite um numero de no maximo 10 digitos: ";
    cin >> num;
    inverter(num);
    return 0;
}

