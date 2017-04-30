namespace Stock.BL.ImportPipes.Abstract
{
    public abstract class BasePipe<TIn, TOut>
    {
        protected readonly TIn _inputData;
        protected BasePipe(TIn inputData)
        {
            _inputData = inputData;
        }

        public abstract TOut Process();
    }
}
