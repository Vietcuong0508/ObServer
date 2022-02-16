namespace ObserverDemo
{
    public interface IObserver
    {
        // Nhận thông tin cập nhật từ chủ thể
        void Update(ISubject subject);
    }
}
