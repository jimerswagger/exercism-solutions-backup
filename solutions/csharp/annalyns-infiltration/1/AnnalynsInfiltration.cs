static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        if (knightIsAwake != true) {
            return true;
        }
        else {
            return false;
        }
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanFastAttack() method");
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if (knightIsAwake || archerIsAwake || prisonerIsAwake) {
            return true;
        }
        else {
            return false;
        }
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanSpy() method");
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {

        if (prisonerIsAwake && archerIsAwake != true) {
            return true;
        }
        else {
            return false;
        }
        
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanSignalPrisoner() method");
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if (petDogIsPresent && archerIsAwake != true) {
            return true;
        }
        else if (petDogIsPresent != true && prisonerIsAwake && archerIsAwake != true && knightIsAwake != true){
            return true;
        }
        else {
            return false;
        }
        
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanFreePrisoner() method");
    }
}
