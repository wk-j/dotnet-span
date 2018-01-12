function flatten(arr) {
    return [].concat(...arr);
}

var input = [[1, 2], [3, 4], [3, 4, 5, 6, [5, 5, 5], 7]]
var rs = flatten(input);
console.log(rs);

var [a, b, ...x] = [1, 3, 4, 5, 6]
console.log(x);