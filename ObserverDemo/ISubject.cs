namespace ObserverDemo
{
    public interface ISubject
    {
        // Gắn một observer đến chủ thể.
        void Attach(IObserver observer);

        // Tách một observer từ chủ thể.
        void Detach(IObserver observer);

        // Thông báo tất cả observers về sự kiện.
        void Notify();
    }
}
