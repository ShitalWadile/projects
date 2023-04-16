import { Component } from '@angular/core';

@Component({
  selector: 'app-calculator',
  templateUrl: './calculator.component.html',
  styleUrls: ['./calculator.component.css']
})
export class CalculatorComponent {
    public p:number=10000;
    public r:number=10.15;
    public n:number=1;
    public EMI=0;

    public AmountChange(e:any){
      this.p=e.target.value;
        }

        public YearChange(e:any){
          this.n=e.target.value;
        }

        public RateChange(e:any){
          this.r=e.target.value;
        }

        public CalculateClick(){
              var n=this.n*12;
              var r=this.r/12/100;
              // alert(`Periods: ${this.n}\nRate : ${this.r}`);
              this.EMI=this.p * r *Math.pow(1+r, n)/ Math.pow(1+r,n)-1;
        }
}
