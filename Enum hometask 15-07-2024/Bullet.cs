using System;
using System.Collections.Generic;

public enum BulletType
{
    mm5_56,
    mm9,
    mm7_62
}

public class Bullet
{
    private static int _idCounter = 1;
    public int Id { get; private set; }
    public BulletType Type { get; private set; }

    public Bullet(BulletType type)
    {
        Id = _idCounter++;
        Type = type;
    }

    public override string ToString()
    {
        return $"Bullet ID: {Id}, Type: {Type}";
    }
}