#include <iostream>
#include <thread>
#include <vector>
#include <list>
#include <mutex>

using namespace std;

mutex mtx;

void FirstMessage(const string &oneString)
{

    unique_lock<mutex> ulOne(mtx);

    for (char symbol : oneString)
    {
        cout << symbol;
        this_thread::sleep_for(chrono::milliseconds(100));
    }

    cout << endl;

    ulOne.unlock();
};

void SecondMessage(const string &twoString)
{

    this_thread::sleep_for(chrono::milliseconds(2));

    unique_lock<mutex> ulTwo(mtx);

    for (auto symbol : twoString)
    {
        cout << symbol;
        this_thread::sleep_for(chrono::milliseconds(100));
    }
    cout << endl;

    ulTwo.unlock();
};

int main()
{
    setlocale(LC_ALL, "ru");

    cout << "Деревня Глинберг" << endl;

    thread oneFlow(FirstMessage, "Добро пожаловать в нашу деревню случайный путешественник");
    thread twoFlow(SecondMessage, "Можете помочь нам с разбойниками?");

    string person;

    cin >> person;    

    SecondMessage("Мы вам хорошо заплатим за помощь");

    oneFlow.join();
    twoFlow.join();

    return 0;
}

