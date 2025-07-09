using System.IO;

namespace TestTask.Core.Import
{
    public class NonClosableStream(Stream root) : Stream
    {
        public bool AllowClose { get; set; }

        public override bool CanRead => root.CanRead;

        public override bool CanSeek => root.CanSeek;

        public override bool CanWrite => root.CanWrite;

        public override long Length => root.Length;

        public override long Position
        {
            get => root.Position;
            set => root.Position = value;
        }

        public override void Close()
        {
            if (AllowClose)
            {
                root.Close();
            }
        }

        public override void Flush() => root.Flush();

        public override int Read(byte[] buffer, int offset, int count)
            => root.Read(buffer, offset, count);

        public override long Seek(long offset, SeekOrigin origin)
            => root.Seek(offset, origin);

        public override void SetLength(long value)
            => root.SetLength(value);

        public override void Write(byte[] buffer, int offset, int count)
            => root.Write(buffer, offset, count);
    }
}
