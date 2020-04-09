namespace SEDC.eStore.Entities.Helpers
{
    public static class IdGenerator
    {
        private static int _id = 0;
        public static int GenerateId()
        {
            _id++;
            return _id;
        }
    }
}
