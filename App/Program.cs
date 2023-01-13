

using Observer.Version3;

internal class Program
{
    private static void Main(string[] args)
    {
        IMySubject subject = new SubjectOne();
        IMyObserver a = new ObserverOne();
        IMyObserver b = new ObserverTwo();

        subject.AddObserver(a);
        subject.AddObserver(b);

        ((SubjectOne)subject).SetStateOne(new StateOne { StateValue1=2,StateValue2="qwerty"});

        subject.RemoveObserver(a);
        Console.WriteLine($"Number of Observers: {((SubjectOne)subject).GetNumberOfObservers()}");
    }
}