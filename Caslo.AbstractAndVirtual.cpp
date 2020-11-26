#include <iostream>
#include <string>

using namespace std;


class Character
{
public:
    virtual void Skill() = 0;
};

class Mage : public Character
{
public:
    void Skill() override
    {
        cout << "Fire Blast" << endl;
    }
};

class Rouge : public Character
{
public:
    void Skill() override
    {
        cout << "Back Step" << endl;
    }
};

class Warrior : public Character
{
public:
    void Skill() override
    {
        cout << "Dash" << endl;
    }
};

class Shaman : public Mage
{
public:
    void Skill() override
    {
        cout << "Storm Blow" << endl;
    }
};

class Player
{
public:
    void Skill(Character * character)
    {
        character->Skill();
    }
};

int main()
{
    setlocale(LC_ALL, "ru");

    Shaman shaman;

    Player player;
    player.Skill(&shaman);


    return 0;
}