defmodule EulerTest do
  use ExUnit.Case
  doctest Euler

  test Problem1_FindSumOfMultiplesOfThreeAndFiveBelow10 do
    assert Euler.p1(0,1,10) == 23
  end
  
  test Problem1_FindSumOfMultiplesOfThreeAndFiveBelow100 do
    assert Euler.p1(0,1,1000) == 233168
  end
end
