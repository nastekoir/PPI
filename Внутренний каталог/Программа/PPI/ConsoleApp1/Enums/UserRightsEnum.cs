namespace ConsoleApp1.Enums
{
    /// <summary>
    ///  Права пользователя
    /// </summary>
    public enum UserRightsEnum
    {
        /// <summary>
        ///  Создание ветки
        /// </summary>
        CreateBranch,

        /// <summary>
        ///  Удаление ветки
        /// </summary>
        DeleteBranch,

        /// <summary>
        ///  Бан пользователя
        /// </summary>
        BanUser,

        /// <summary>
        ///  Разбан пользователя
        /// </summary>
        UnBanUser,

        /// <summary>
        ///  Отправка сообщения
        /// </summary>
        AddMessage,

        /// <summary>
        ///  Удаление сообщения
        /// </summary>
        DeleteMessage,

        /// <summary>
        ///  Удаление сообщения любого пользователя
        /// </summary>
        DeleteUserMessage,

        /// <summary>
        ///  Чтение сообщений
        /// </summary>
        ReadMessages,
		
		/// <summary>
        ///  Запретить пользователю писать сообщения
        /// </summary>
		MuteUser

    }
}
