function HitIncrementInJs(dotNetObject) {
    dotNetObject.invokeMethodAsync("HitIncrement");
    console.log("invoked HitIncrementInJs");
}

function HitMessageChangeInJs(dotNetObject, txt) {
    return dotNetObject.invokeMethodAsync("ChangeMesage", txt);
}