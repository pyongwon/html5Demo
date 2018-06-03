let performComplexCalculation = (seed) => {
  // very complex logic - bogus
  let k;
  for (let i = 0; i < 100000; i++) {
    for (let j = 0; j < 10000; j++) {
      k = 0;
    }
  }
  return parseInt(seed) + 100;
}

self.addEventListener("message", (event) => {
  let result = performComplexCalculation(event.data);
  self.postMessage(result);
}, false);