class carteira
{
  public double lucro_prejuizo;
  public double rentabilidade;
  public double saldo_inicial;
  public string instituicao_financeira;
public void setLucro(double novolucro  ){
  lucroprejuizo=novolucro;
}
 private double setSaldo(double novosaldo){
  saldo_inicial=novosaldo;

 public string getBanco(){
  return instituicao_financeira;
 }
   public void inserirsaldo() {
  Console.WriteLine("Quanto de saldo disponível você tem para investir?");
  double sd_disponivel = double.Parse(Console.ReadLine());
 }
public carteira(double lucro_prejuizo,double rentabilidade,double saldo_inicial){
 this.lucro_prejuizo=lucro_prejuizo;
  this.saldo_inicial=saldo_inicial;
  this.instituicao_financeira=instituicao_financeira;
}
