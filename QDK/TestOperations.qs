namespace TestOperations {

    operation SetQubitState(desired : Result, target : Qubit) : Unit {
        if desired != M(target) {
            X(target);
        }
    }

    operation SayHelloQ() : Unit {
        Message("Hello quantum world!");
        mutable numOnesQ1 = 0;
        use q = Qubit();
        for test in 1..count {
            SetQubitState(Zero, q1);
            let resultQ1 = M(q1);
            if resultQ1 == One {
                set numOnesQ1 += 1;
            }
        }
    }

    operation TestNumberOfQubits(n: Int) : Unit {

        use qubits = Qubit[n];
        for index in 0 .. 128 {
            for qubit in qubits {
                H(qubit);
            }
        }

        for qubit in qubits {
                Reset(qubit);
        }
    }

    operation TestDepthOfCircuit(n: Int) : Unit {

        use qubits = Qubit[4];
        for index in 0 .. 128 {
            for qubit in qubits {
                for i in 0 .. n {
                    H(qubit);
                }
            }
        }

        for qubit in qubits {
                Reset(qubit);
        }
    }
}