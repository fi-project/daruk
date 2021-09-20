namespace Fi.Daruk.Telemetry

module RawTelemetry =
  type Attribute = { Key: string; Value: Chiron.Json }

  type Span =
    { TraceId: string;
      SpanId: string;
      Name: string;
      StartTimeUnixNano: int64;
      EndTimeUnixNano: int64 }
