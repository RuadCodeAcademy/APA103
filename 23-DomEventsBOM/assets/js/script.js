let plusbtn = document.querySelector(".plus");
let minusbtn = document.querySelector(".minus");
let multbtn = document.querySelector(".mult");
let devidebtn = document.querySelector(".devide");
let Total = document.querySelector("#total");


const validateAndGetValues = () => {
    let oneinput = document.querySelector("#oneinput");
    let twoinput = document.querySelector("#twoinput");


    let val1 = oneinput.value.replace(',', '.').trim();
    let val2 = twoinput.value.replace(',', '.').trim();


    if (val1 === "" || val2 === "") {
        alert("Xanaları boş qoymayın!");
        oneinput.value = "";
        twoinput.value = "";
        return null;
    }

    let n1 = Number(val1);
    let n2 = Number(val2);


    if (isNaN(n1) || isNaN(n2)) {
        alert("Xahiş olunur yalnız rəqəm daxil edin!");
        oneinput.value = "";
        twoinput.value = "";
        return null;
    }

    return { n1, n2, input1: oneinput, input2: twoinput };
};

let Sum = () => {
    let res = validateAndGetValues();
    if (!res) return;
    Total.value = res.n1 + res.n2;
    res.input1.value = ""; res.input2.value = "";
};

let Sub = () => {
    let res = validateAndGetValues();
    if (!res) return;
    Total.value = res.n1 - res.n2;
    res.input1.value = ""; res.input2.value = "";
};

let Mul = () => {
    let res = validateAndGetValues();
    if (!res) return;
    Total.value = res.n1 * res.n2;
    res.input1.value = ""; res.input2.value = "";
};

let Dev = () => {
    let res = validateAndGetValues();
    if (!res) return;

    if (res.n2 === 0) {
        alert("Sıfıra bölmək olmaz!");
        res.input1.value = ""; 
        res.input2.value = "";
        return;
    }

    let netice = res.n1 / res.n2;
    Total.value = Number.isInteger(netice) ? netice : netice.toFixed(2);

    res.input1.value = "";
    res.input2.value = "";
};

plusbtn.addEventListener("click", Sum);
minusbtn.addEventListener("click", Sub);
multbtn.addEventListener("click", Mul);
devidebtn.addEventListener("click", Dev);