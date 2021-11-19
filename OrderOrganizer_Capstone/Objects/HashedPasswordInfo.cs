namespace OrderOrganizer_Capstone.Objects
{
    public struct HashedPasswordInfo
    {
        public HashedPasswordInfo(byte[] _salt, string _storedPasswordHash)
        {
            PasswordHash = _storedPasswordHash;
            Salt = _salt;
        }
        public string PasswordHash { get; }
        public byte[] Salt { get; }
    }
}
