#include <iostream>
using namespace std;

template<typename T>
void SwapValue(T &a, T &b)
{
    T temp = a;
    a = b;
    b = temp;
}

int main()
{
    setlocale(LC_ALL, "ru");
    int varOne = 64;
    int varTwo = 21;

    cout << "Var 1 " << varOne << endl;
    cout << "Var 2 " << varTwo << endl;

    cout << "Swap" << endl;

    SwapValue(varOne, varTwo);

    cout << "Var 1 " << varOne << endl;
    cout << "Var 2 " << varTwo << endl;
}