#include <iostream>
#include <string>

using namespace std;


class Player;
class Character;
class CharacterPrint;


class Player
{
public:

    Player(string Name, int id)
    {
        cout << Name << endl;
        cout << id << endl << endl;
    }

private:
    string Name;
    int id;
};

class Character
{
public:

    static int Quantity;

    Character(string characterName, int lvl)
    {
        this->characterName = characterName;
        this->lvl = lvl;
        Quantity++;
        number = Quantity;
    }

    int GetNum()
    {
        return number;
    }

    void Print()
    {
        cout << characterName << "\t" << lvl << endl;
    }

private:
    int lvl;
    string characterName;
    int number;
};

int Character::Quantity = 0;


int main()
{
    setlocale(LC_ALL, "ru");

    Player firstPlayer("Евгений", 2104);

    Character character1("Caslo", 21);
    Character character2("Thift", 50);
    Character character3("Pudman", 4);

    //cout << character1.Print << endl;
    cout << "Номер персонажа" << endl;
    cout << character1.GetNum() << endl << endl; 
    cout << "Количество персонажей" << endl;
    cout << character1.Quantity << endl << endl;

}