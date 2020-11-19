#include <iostream>
#include <ctime>

using namespace std;

int main()
{
    setlocale(LC_ALL, "ru");
    srand(time(NULL));

    const int SIZE = 10;

    int arr[SIZE];

    bool alreadyHere;

    for (int i = 0; i < SIZE;)
    {
        alreadyHere = false;
        int newrndValue = rand() % 100;

        for (int j = 0; j < i; j++)
        {
            if (arr[j] == newrndValue)
            {
                alreadyHere = true;
                break;
            }
        }

        if (!alreadyHere)
        {
            arr[i] = newrndValue;
            i++;
        }

    }

    for (int i = 0; i < SIZE; i++)
    {
        cout << arr[i] << endl;
    }

    int minValue = arr[0];

    for (int i = 0; i < SIZE; i++)
    {
        if (arr[i] < minValue)
        {
            minValue = arr[i];
        }
    }

    cout << "Наименьшее число в массиве: " << minValue << endl;

    int maxValue = arr[0];

    for (int i = 0; i < SIZE; i++)
    {
        if (arr[i] > maxValue)
        {
            maxValue = arr[i];
        }
    }

    cout << "Наибольшее число в массиве: " << maxValue << endl;
}
