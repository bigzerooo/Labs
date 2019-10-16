using System;
static class FoodFactory
{
    public static Food Create(string name)
    {
        return new Food(name);
    }
}
static class MoodFactory
{
    public static Mood Create(int happiness)
    {
        return new Mood(happiness);
    }
}