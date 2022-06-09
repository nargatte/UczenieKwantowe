import cirq
import qsimcirq
import time

def test(numSamples, numThreads, numQubits, depth):
    qs = cirq.LineQubit.range(numQubits)
    hs = [cirq.H(x) for x in qs]
    lhs = []
    for _ in range(depth):
        lhs = lhs + hs
    ms = [cirq.measure(x) for x in qs]
    circuit = cirq.Circuit(lhs + ms)
    qsim_simulator = qsimcirq.QSimSimulator({'t': numThreads})
    start = time.time()
    for _ in range(numSamples):
        results = qsim_simulator.simulate(circuit)
    elapsed = time.time() - start
    return(elapsed)