using System;
public class Principal
{
	static void Main(string[] args)
	{
		TVA min = new TVA(5.5);
		TVA mid = new TVA(10);
		TVA max = new TVA(20);

		Produit Banane = new Produit("Banane",2,mid);

		string description1 = "Le prix de la " + Banane.getNom() + " TTC est de " + Banane.getTVA().getTTC(Banane) + " euros. Le prix HT etait de " + Banane.getHT() + " euros.";
		Console.WriteLine(description1);

		Produit Patate = new Produit("Patate",1.5,min);

		string description2 = "Le prix de la " + Patate.getNom() + " TTC est de " + Patate.getTVA().getTTC(Patate) + " euros. Le prix HT etait de " + Patate.getHT() + " euros.";
		Console.WriteLine(description2);
	}

}
public class TVA 
{
	private double taux;
	private double TTC;
	public TVA(double t)
	{
		this.taux = t;
	}
	public double getTaux()
	{
		return this.taux;
	}
	public void setTaux(double t)
	{
		this.taux = t;
	}
	public double getTTC(Produit p)
	{
		TTC = p.getHT() * (1+(this.taux/100));
		return this.TTC;
	}
}
public class Produit
{ 
	private string nom;
	private double prix_HT;
	private TVA tva;

	public Produit(string n, double ht, TVA t)
	{
		this.nom = n;
		this.prix_HT = ht;
		this.tva = t;
	}
	public double getHT()
	{ 
		return this.prix_HT;
	}
	public void setHT(double ht)
	{
		this.prix_HT = ht;
	}
	public string getNom()
	{ 
		return this.nom;
	}
	public void setNom(string n)
	{
		this.nom = n;
	}
	public TVA getTVA()
	{
		return this.tva;
	}
	public void setTVA(TVA t)
	{
		this.tva = t;
	}
}