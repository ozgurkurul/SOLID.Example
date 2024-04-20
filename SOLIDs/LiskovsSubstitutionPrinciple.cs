namespace SOLIDs.LiskovsSubstitutionPrinciple.Unsuitable
{
    public abstract class BasePrinter
    {
        public abstract void Print(string value);
        public abstract void Scan(string value);
    }

    public class HPPrinter : BasePrinter
    {
        public override void Print(string value)
        {

        }
        public override void Scan(string value)
        {
            throw new NotImplementedException();
        }
    }

    public class CanonPrinter : BasePrinter
    {
        public override void Print(string value)
        {

        }
        public override void Scan(string value)
        {

        }
    }

    public class Printer
    {
        private readonly BasePrinter _hpPrinter = new HPPrinter();
        private readonly BasePrinter _canonPrinter = new CanonPrinter();
        public void Print(string value)
        {
            //canon için herhangi bir hata oluşmayacak
            _canonPrinter.Print(value);
            _canonPrinter.Scan(value);

            //hp'de ise scan özelliği olmadığı için hata alacağız
            _hpPrinter.Print(value);
            _hpPrinter.Scan(value);
        }
    }
}

namespace SOLIDs.LiskovsSubstitutionPrinciple.Suitable
{

    public abstract class BasePrinter
    {
        public abstract void Print(string value);
    }

    public interface IScan
    {
        void Scan(string value);
    }

    public class HPPrinter : BasePrinter
    {
        public override void Print(string value)
        {

        }
    }

    public class CanonPrinter : BasePrinter, IScan
    {
        public override void Print(string value)
        {

        }
        public void Scan(string value)
        {

        }
    }

    public class Printer
    {
        private readonly BasePrinter _hpPrinter = new HPPrinter();
        private readonly BasePrinter _canonPrinter = new CanonPrinter();
        private readonly IScan _canonScanner = new CanonPrinter();
        public void Print(string value)
        {
            _canonPrinter.Print(value);
            _canonScanner.Scan(value);

            _hpPrinter.Print(value);
        }
    }
}