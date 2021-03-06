﻿using System;

namespace xNet.Net
{
    /// <summary>
    /// Представляет данные для события, сообщающим о прогрессе загрузки данных.
    /// </summary>
    public sealed class DownloadProgressChangedEventArgs : EventArgs
    {
        #region Свойства (открытые)

        /// <summary>
        /// Возвращает количество полученных байтов.
        /// </summary>
        public int BytesReceived { get; private set; }

        /// <summary>
        /// Возвращает общее количество получаемых байтов.
        /// </summary>
        /// <value>Если общее количество получаемых байтов неизвестно, то значение -1.</value>
        public int TotalBytesToReceive { get; private set; }

        /// <summary>
        /// Возвращает процент полученных байтов.
        /// </summary>
        public double ProgressPercentage
        {
            get
            {
                return ((double)BytesReceived / (double)TotalBytesToReceive) * 100.0;
            }
        }

        #endregion


        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="DownloadProgressChangedEventArgs"/>.
        /// </summary>
        /// <param name="bytesReceived">Количество полученных байтов.</param>
        /// <param name="totalBytesToReceive">Общее количество получаемых байтов.</param>
        public DownloadProgressChangedEventArgs(int bytesReceived, int totalBytesToReceive)
        {
            BytesReceived = bytesReceived;
            TotalBytesToReceive = totalBytesToReceive;
        }
    }
}