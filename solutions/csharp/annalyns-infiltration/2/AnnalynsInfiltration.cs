static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        if (knightIsAwake != true)
            return true;
        
        return false;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if (knightIsAwake || archerIsAwake || prisonerIsAwake)
            return true;
        
        return false;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {

        if (prisonerIsAwake && archerIsAwake != true)
            return true;
        
        return false;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if (petDogIsPresent && archerIsAwake != true)
            return true;
            
        if (petDogIsPresent != true && prisonerIsAwake && archerIsAwake != true && knightIsAwake != true)
            return true;
        
        return false;
    }
}
