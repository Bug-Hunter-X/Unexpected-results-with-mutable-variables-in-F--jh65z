This example demonstrates a common pitfall in F#: using mutable variables in calculations.  The value of `z` is calculated initially using the initial values of `x` and `y`, and this value isn't automatically updated when `x` changes. This is a subtle bug that might appear in applications that involve updating data structures.