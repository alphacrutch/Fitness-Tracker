using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Exercise
{
    public string Name;
    public string Description;
    public List<string> steps;

    public ExerciseCategory category;
    public Muscle TargetMuscle;
    public MuscleGroup MuscleGroup;
    public Difficulty Difficulty;

    public int RecommendedSets;
    public int RecommendedReps;
    public int CurrentReps;
    public int CurrentSets;
    public int RecommendedTime;
    public int CurrentTime;
}
[System.Serializable]
public enum ExerciseCategory { UpperBody, LowerBody, Cardio, Stretching, Abs, Boxing };
[System.Serializable]
public enum Difficulty { Easy, Medium, Hard }

[System.Serializable]
public enum Muscle
{
    // Chest
    PectoralisMajor,
    PectoralisMinor,

    // Back
    LatissimusDorsi,
    Trapezius,
    Rhomboids,
    ErectorSpinae,
    TeresMajor,
    TeresMinor,
    Infraspinatus,

    // Shoulders
    DeltoidAnterior,
    DeltoidLateral,
    DeltoidPosterior,
    RotatorCuff,

    // Arms
    BicepsBrachii,
    TricepsBrachii,
    Brachialis,
    ForearmFlexors,
    ForearmExtensors,

    // Legs
    Quadriceps,
    Hamstrings,
    Calves,
    Sartorius,
    Adductors,
    Abductors,

    // Core
    RectusAbdominis,
    Obliques,
    TransverseAbdominis,

    // Glutes
    GluteusMaximus,
    GluteusMedius,
    GluteusMinimus,

    // Misc / Full body
    Heart,         // For cardio
    Neck,
    LowerBack
}

[System.Serializable]
public enum MuscleGroup
{
    Chest,
    Back,
    Shoulders,
    Arms,
    Legs,
    Core,
    Glutes,
    FullBody,
    Cardio
}

[System.Serializable]
public class Exercises
{
    public List<Exercise> stretching;
    public List<Exercise> boxing;
    public List<Exercise> cardio;
    public List<Exercise> legs;
    public List<Exercise> upperBody;
    public List<Exercise> abs;
}


public static class ExersicesExt
{
    public static Exercise GetStretchingExercise(this Exercises exercises, string name)
    {
        Exercise exercise = new Exercise();
        exercise = exercises.stretching.Find(e => e.Name == name);
        return exercise;
    }
    public static Exercise GetLowerBodyExercise(this Exercises exercises, string name)
    {
        Exercise exercise = new Exercise();
        exercise = exercises.stretching.Find(e => e.Name == name);
        return exercise;
    }
    public static Exercise GetUpperBodyExercise(this Exercises exercises, string name)
    {
        Exercise exercise = new Exercise();
        exercise = exercises.stretching.Find(e => e.Name == name);
        return exercise;
    }
    public static Exercise GetBoxingExercise(this Exercises exercises, string name)
    {
        Exercise exercise = new Exercise();
        exercise = exercises.stretching.Find(e => e.Name == name);
        return exercise;
    }
    public static Exercise GetCardioExercise(this Exercises exercises, string name)
    {
        Exercise exercise = new Exercise();
        exercise = exercises.stretching.Find(e => e.Name == name);
        return exercise;
    }
    public static Exercise GetAbExercise(this Exercises exercises, string name)
    {
        Exercise exercise = new Exercise();
        exercise = exercises.stretching.Find(e => e.Name == name);
        return exercise;
    }
}
