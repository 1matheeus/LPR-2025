#include <iostream>
#include <string>

using namespace std;
int main()
{
    cout << "Digite dois números para ver se são multiplos!" << endl;
    cout << "Insira os números separados por espaço: ";
    int num1, num2;
    cin >> num1 >> num2;
    if (num1 % num2 == 0 || num2 % num1 == 0)
    {
        cout << "Os números são múltiplos!" << endl;
    }
    else
    {
        cout << "Os números não são múltiplos!" << endl;
    }
    return 0;
}