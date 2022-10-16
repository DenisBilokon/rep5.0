
class ExcelentPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Вiдмiнник: Вчиться - вiдмiнно");
    }
    public override void Read()
    {
        Console.WriteLine("Вiдмiнник: Читає - вiдмiнно");
    }
    public override void Write()
    {
        Console.WriteLine("Вiдмiнник: Пишe - вiдмiнно");
    }
    public override void Relax()
    {
        Console.WriteLine("Вiдмiнник: Вiдпочиває - вiдмiнно");
    }

}
class GoodPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Гарний Учень: Вчиться - гарно");
    }
    public override void Read()
    {
        Console.WriteLine("Гарний Учень: Читає - гарно");
    }
    public override void Write()
    {
        Console.WriteLine("Гарний Учень: Пишe - гарно");
    }
    public override void Relax()
    {
        Console.WriteLine("Гарний Учень: Вiдпочиває - гарно");
    }

}
class BadPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Поганий учень: Вчиться - погано ");
    }
    public override void Read()
    {
        Console.WriteLine("Поганий учень: Читає - погано");
    }
    public override void Write()
    {
        Console.WriteLine("Поганий учень: Пишe - погано");
    }
    public override void Relax()
    {
        Console.WriteLine("Поганий учень: Вiдпочиває - погано");
    }

}
class ClassRoom
{
    Pupil[] arrPupil;

    public ClassRoom(Pupil p1, Pupil p2, Pupil p3, Pupil p4)
    {
        arrPupil = new Pupil[] { p1, p2, p3, p4 };
    }
    public ClassRoom(Pupil p1, Pupil p2, Pupil p3)
    {
        arrPupil = new Pupil[] { p1, p2, p3 };
    }
    public ClassRoom(Pupil p1, Pupil p2)
    {
        arrPupil = new Pupil[] { p1, p2 };
    }

    public void PrintInfoStudy()
    {
        Console.WriteLine("Вчиться: ");
        foreach (Pupil item in arrPupil)
            item.Study();
    }
    public void PrintInfoRead()
    {
        Console.WriteLine("Читає: ");
        foreach (Pupil item in arrPupil)
            item.Read();
    }
    public void PrintInfoWrite()
    {
        Console.WriteLine("Пише: ");
        foreach (Pupil item in arrPupil)
            item.Write();
    }
    public void PrintInfoRelax()
    {
        Console.WriteLine("Вiдпочиває: ");
        foreach (Pupil item in arrPupil)
            item.Relax();
    }
}

class Program
{
    static void Main()
    {
        ClassRoom cRoom = new ClassRoom(new ExcelentPupil(), new GoodPupil(), new BadPupil(), new GoodPupil());

        cRoom.PrintInfoRead();
        cRoom.PrintInfoRelax();
        cRoom.PrintInfoStudy();
        cRoom.PrintInfoWrite();

        Console.ReadKey();
    }
}

class Pupil
{
    public virtual void Study()
    { }

    public virtual void Read()
    { }

    public virtual void Write()
    { }

    public virtual void Relax()
    { }
}
