namespace Game.Services
{
    public interface IPlayerDataProvider
    {
        public PlayerDataModel Load();
        public void Save(PlayerDataModel data);
    }
}