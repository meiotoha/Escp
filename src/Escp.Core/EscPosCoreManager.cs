using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using Escp.Core.Core;

namespace Escp.Core
{

    public class EscPosCoreManager : IEscPosCoreManager,IEscPosCore, IDisposable
    {
        // ReSharper disable InconsistentNaming
        public const string DefaultEncoding = "gbk";
        public const byte LF                = 0x0A;
        public const byte ESC               = 0x1B;
        public const byte CR                = 0x0D;
        public const byte NUL               = 0x00;
        public const byte HT                = 0x09;
        public const byte FF                = 0x0C;
        public const byte GS                = 0x1D;
        public const byte FS                = 0x1C;
        public const byte DLE               = 0x10;
        public const byte EOT               = 0x04;
        public const byte ENQ               = 0x05;
        public const byte CAN               = 0x18;

        // ReSharper restore InconsistentNaming

        #region Connect


        public static IEscPosCoreManager Connect(Stream stream, Encoding encoding) => new EscPosCoreManager(stream, encoding);
        public static IEscPosCoreManager Connect(Stream stream, string encoding = DefaultEncoding) => Connect(stream, Encoding.GetEncoding(encoding));
        public static IEscPosCoreManager Connect(string ip, ushort port, Encoding encoding)
        {
            var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            socket.Connect(ip, port);
            var ns = new NetworkStream(socket);
            return Connect(ns, encoding);
        }
        public static IEscPosCoreManager Connect(string ip, ushort port = 9000, string encoding = DefaultEncoding) => Connect(ip, port, Encoding.GetEncoding(encoding));

        #endregion

        private readonly Encoding _encoding;
        private readonly Stream _stream;
        private readonly BinaryWriter _writer;

        private EscPosCoreManager(Stream stream, Encoding encoding)
        {
            _encoding = encoding ?? Encoding.GetEncoding(DefaultEncoding);
            _stream = stream;
            _writer = new BinaryWriter(_stream, _encoding);
        }

        private BinaryWriter Write(params byte[] bytes)
        {
            _writer.Write(bytes);
            return _writer;
        }

        #region IEscPosCoreManager

        public IEscPosCore Begin()
        {
            return null;
        }

        #endregion


        #region IDisposable Support

        private bool _isDisposed = false; // 要检测冗余调用

        protected virtual void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    _writer.Dispose();
                    _stream.Dispose();
                }
                _isDisposed = true;
            }
        }

        ~EscPosCoreManager()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion

        public IEscPosCore Init()
        {
            throw new NotImplementedException();
        }

        public IEscPosCore Align(byte position)
        {
            throw new NotImplementedException();
        }

        public IEscPosCore Align(Alignment position)
        {
            throw new NotImplementedException();
        }

        public IEscPosCore FontSize(byte size)
        {
            throw new NotImplementedException();
        }

        public IEscPosCore SetFontSize(FontSize size)
        {
            throw new NotImplementedException();
        }

        public IEscPosCore ResetFontSize()
        {
            throw new NotImplementedException();
        }

        public IEscPosCore Bold(bool isBold)
        {
            throw new NotImplementedException();
        }

        public IEscPosCore SetBold()
        {
            throw new NotImplementedException();
        }

        public IEscPosCore UnsetBold()
        {
            throw new NotImplementedException();
        }

        public IEscPosCore Underline(bool isUnderlined)
        {
            throw new NotImplementedException();
        }

        public IEscPosCore SetUnderline()
        {
            throw new NotImplementedException();
        }

        public IEscPosCore UnsetUnderline()
        {
            throw new NotImplementedException();
        }

        public IEscPosCore FontScale(byte scale)
        {
            throw new NotImplementedException();
        }

        public IEscPosCore SetFontScale(ScaleMode scale)
        {
            throw new NotImplementedException();
        }

        public IEscPosCore ResetFontScale()
        {
            throw new NotImplementedException();
        }

        public IEscPosCore LineFeed(int lineNum = 1)
        {
            throw new NotImplementedException();
        }

        public IEscPosCore PrintText(string text)
        {
            throw new NotImplementedException();
        }

        public IEscPosCore FeedAndCut()
        {
            throw new NotImplementedException();
        }
    }
}
