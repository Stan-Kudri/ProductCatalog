using TestTask.Core.Models.Modes;

namespace TestTask.BindingItem.UserBinding
{
    public class ModeModel : ModelBase
    {
        private string _name = string.Empty;
        private int _maxBottleNumber = 0;
        private int _maxUsedTips = 0;

        public ModeModel(string name, int maxBottleNumber, int maxUsedTips)
        {
            _name = name;
            _maxBottleNumber = maxBottleNumber;
            _maxUsedTips = maxUsedTips;
        }

        public string Name
        {
            get => _name;
            set => SetField(ref _name, value);
        }

        public int MaxBottleNumber
        {
            get => _maxBottleNumber;
            set => SetField(ref _maxBottleNumber, value);
        }

        public int MaxUsedTips
        {
            get => _maxUsedTips;
            set => SetField(ref _maxUsedTips, value);
        }

        public static ModeModel GetModeModel(string name, int maxBottleNumber, int maxUsedTips) => new ModeModel(name, maxBottleNumber, maxUsedTips);

        public Mode ToMode() => new Mode(_name, _maxBottleNumber, _maxUsedTips);

        public Mode ToMode(int id) => new Mode(_name, _maxBottleNumber, _maxUsedTips, id);
    }
}
