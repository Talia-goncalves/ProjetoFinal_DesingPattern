using System;

public class Monster
{
    public string Name { get; private set; }
    public int HP { get; private set; }
    public int EP { get; private set; }
    public int AttackPower { get; private set; }
    public int Defense { get; private set; }
    public string SpecialAbility { get; private set; }

    public Monster(string name, int hp, int ep, int attack, int defense, string ability)
    {
        Name = name;
        HP = hp;
        EP = ep;
        AttackPower = attack;
        Defense = defense;
        SpecialAbility = ability;
    }

    public void TakeDamage(int damage)
    {
        int reducedDamage = damage - Defense;
        HP -= reducedDamage > 0 ? reducedDamage : 0;
        Console.WriteLine($"{Name} sofreu {reducedDamage} de dano. HP restante: {HP}");
    }

    public void Attack(Monster target)
    {
        Console.WriteLine($"{Name} ataca {target.Name}!");
        target.TakeDamage(AttackPower);
    }

    public void Defend()
    {
        Console.WriteLine($"{Name} se defende, reduzindo o dano recebido.");
        Defense += 2;
    }

    public void UseSpecialAbility(Monster target)
    {
        if (EP > 0)
        {
            Console.WriteLine($"{Name} usa sua habilidade especial: {SpecialAbility}!");
            target.TakeDamage(AttackPower * 2);  // Habilidade especial causa o dobro de dano
            EP -= 1;
        }
        else
        {
            Console.WriteLine($"{Name} não tem energia suficiente para usar {SpecialAbility}.");
        }
    }

    public bool IsDefeated()
    {
        return HP <= 0;
    }
}
