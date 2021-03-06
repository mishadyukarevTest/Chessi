using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal struct EconomyMasterComponent
{
    private int _goldMaster;
    private int _goldOther;

    internal int GoldMaster => _goldMaster;
    internal int GoldOther => _goldOther;


    internal EconomyMasterComponent(NameValueManager nameValueManager)
    {
        _goldMaster = nameValueManager.GOLD_MASTER;
        _goldOther = nameValueManager.GOLD_OTHER;
    }


    internal int AddGoldMaster(int addGold) => _goldMaster += addGold;
    internal int AddGoldOther(int addGold) => _goldOther += addGold;

    internal int TakeGoldMaster(int takeGold) => _goldMaster -= takeGold;
    internal int TakeGoldOther(int takeGold) => _goldOther -= takeGold;


    internal struct UnitsMasterComponent
    {
        private int _amountUnitPawnMaster;
        private int _amountUnitPawnOther;

        internal int AmountUnitPawnMaster => _amountUnitPawnMaster;
        internal int AmountUnitPawnOther => _amountUnitPawnOther;


        internal UnitsMasterComponent(NameValueManager nameValueManager)
        {
            _amountUnitPawnMaster = nameValueManager.AMOUNT_MASTER_PAWN;
            _amountUnitPawnOther = nameValueManager.AMOUNT_OTHER_PAWN;
        }


        internal void TakeAmountUnitPawnMaster(int takeAmount) => _amountUnitPawnMaster -= takeAmount;
        internal void TakeAmountUnitPawnOther(int takeAmount) => _amountUnitPawnOther -= takeAmount;
        internal void AddAmountUnitPawnMaster(int addAmount) => _amountUnitPawnMaster += addAmount;
        internal void AddAmountUnitPawnOther(int addAmount) => _amountUnitPawnOther += addAmount;
    }



    internal struct BuildingsMasterComponent
    {
        private bool _isSettedCityMaster;
        private bool _isSettedCityOther;
        private int[] _xySettedCityMaster;
        private int[] _xySettedCityOther;

        internal bool IsBuildedCityMaster
        { get { return _isSettedCityMaster; } set { _isSettedCityMaster = value; } }
        internal bool IsBuildedCityOther
        { get { return _isSettedCityOther; } set { _isSettedCityOther = value; } }
        internal int[] XYsettedCityMaster
        { get { return _xySettedCityMaster; } set { _xySettedCityMaster = value; } }
        internal int[] XYsettedCityOther
        { get { return _xySettedCityOther; } set { _xySettedCityOther = value; } }

        internal BuildingsMasterComponent(NameValueManager nameValueManager)
        {
            _isSettedCityMaster = default;
            _isSettedCityOther = default;
            _xySettedCityMaster = new int[nameValueManager.XY_FOR_ARRAY];
            _xySettedCityOther = new int[nameValueManager.XY_FOR_ARRAY];
        }
    }
}
