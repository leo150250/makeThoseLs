let a=4;
let b=document.createElement("div");
for (let i=0; i<7; i++) {
  b.innerHTML+="&block;";
  if (a>0) {
    b.innerHTML+="</br>";
    a--;
  }
}
document.body.appendChild(b);