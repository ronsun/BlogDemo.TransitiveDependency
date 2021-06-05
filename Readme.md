### Introduce
+ `AggregationLib` and `AnotherAggregationLib` both dependent on `BaseLib`
+ `Client` dependent on `AggregationLib` or/and `AnotherAggregationLib` or `BaseLib`.
+ All of above need to pack to packages, and put them to local package source.
  - Go **Tools > Nuget Package Manager > Packag Source**, then add a new package source, then name it and select a local folder to be the source. 
  - Checkout to branchs and pack requried versions of `BaseLib`, `AggregationLib` and `AnotherAggregationLib`, then put them to local pack source.
  - Install packages to project `Client` and demo.
