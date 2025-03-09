// See https://aka.ms/new-console-template for more information

class Program
{
	static void Main(string[] args)
	{
		KodePos kodePos = new KodePos();
		Console.WriteLine("Kode pos Batununggal :");
		Console.WriteLine(kodePos.getKodePos("Batununggal").ToString());

		DoorMachine pintu = new DoorMachine();
		Console.WriteLine("# Membuka pintu");
		pintu.BukaPintu();
		Console.WriteLine("# Mengunci pintu");
		pintu.KunciPintu();
	}
}

class KodePos
{
	public int getKodePos(string kelurahan)
	{
		switch (kelurahan)
		{
			case "Batununggal":
				return 40266;
			case "Kujangsari":
				return 40287;
			case "Mengger":
				return 40267;
			case "Wates":
				return 40256;
			case "Cijaura":
				return 40287;
			case "Jatisari":
				return 40286;
			case "Margasari":
				return 40286;
			case "Sekejati":
				return 40286;
			case "Kebonwaru":
				return 40272;
			case "Maleer":
				return 40274;
			case "Samoja":
				return 40273;
			default:
				return 0;
		}
	}
}

class DoorMachine {
	private bool terkunci = true;

	public void KunciPintu() {
		if (!terkunci) terkunci = true;
		Console.WriteLine("Pintu terkunci");
	}

	public void BukaPintu() {
		if (terkunci) terkunci = false;
		Console.WriteLine("Pintu tidak terkunci");
	}
}
