namespace Chapter_10._05_Best_practices_Mediator
{
    internal interface IWorkflowMediator
    {
        void TriggerEvent(InventoryMonitor inventoryMonitor, string v);
    }
}